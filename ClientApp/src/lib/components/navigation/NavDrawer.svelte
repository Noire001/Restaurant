<script>
    import Navbar from "./Navbar.svelte";
    import {store} from "../../stores/store.ts";

    let drawerContent;
    let drawerContentScrollY = 0;
    function parseContentScroll() {
        drawerContentScrollY = drawerContent.scrollTop;
    }
    let innerHeight = 0;
    const registry = store.menuItemStore.menuItemRegistry
    $:categories = $registry.size > 0 ? store.menuItemStore.menuItemsByCategory : [];
</script>

<svelte:window bind:innerHeight/>

<div class={`drawer ${(drawerContentScrollY > innerHeight - 64) && innerHeight !== 0 ? "drawer-mobile" : ""} absolute`}>
    <input id="drawer" type="checkbox" class="drawer-toggle"/>
    <div bind:this={drawerContent} on:scroll={parseContentScroll} class="drawer-content flex flex-col "
         style="scroll-behavior: smooth; scroll-padding-top: 5rem;">
        <!-- Navbar -->
        <Navbar drawerContentScrollY="{drawerContentScrollY}">
            <slot/>
        </Navbar>
    </div>
    <div class="drawer-side">
        <label for="drawer" class="drawer-overlay"></label>
        <ul class="menu menu-vertical p-4 overflow-y-auto w-80 bg-base-300">
            <li><a class="prose prose-2xl dark:prose-invert -mt-2">Restaurant</a></li>
            {#each [...categories] as [key, value]}
                <li><a href={`#menu-${key.toLowerCase()}`}>{key}</a></li>
            {/each}
        </ul>

    </div>
</div>