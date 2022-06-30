<script>
    import Navbar from "./Navbar.svelte";
    
    let drawerContent;
    let drawerContentScrollY = 0;
    function parseContentScroll() {
        drawerContentScrollY = drawerContent.scrollTop;
    }
    
    let innerHeight = 0;
</script>

<svelte:window bind:innerHeight />

<div class={`drawer ${drawerContentScrollY > innerHeight ? "drawer-mobile" : ""} absolute`}>
    <input id="drawer" type="checkbox" class="drawer-toggle"/>
    <div bind:this={drawerContent} on:scroll={parseContentScroll} class="drawer-content flex flex-col " style="scroll-behavior: smooth; scroll-padding-top: 5rem;">
        <!-- Navbar -->
        <Navbar drawerContentScrollY="{drawerContentScrollY}">
            <slot/>
        </Navbar>
    </div>
    <div class="drawer-side">
        <label for="drawer" class="drawer-overlay"></label>
        <ul class="menu menu-vertical p-4 overflow-y-auto w-80 bg-base-300">
            <li><a class="prose prose-2xl dark:prose-invert">Restaurant</a></li>
            <li><a>Sidebar Item 1</a></li>
            <li><a>Sidebar Item 2</a></li>
        </ul>

    </div>
</div>