<script>
    import Navbar from "./Navbar.svelte";
</script>

<div class="drawer drawer-mobile ">
    <input id="drawer" type="checkbox" class="drawer-toggle"/>
    <div class="drawer-content flex flex-col ">
        <!-- Navbar -->
        <Navbar drawerId="drawer">
            <slot/>
        </Navbar>
    </div>
    <div class="drawer-side">
        <label for="drawer" class="drawer-overlay "></label>
        <ul class="menu p-4 overflow-y-auto w-80 bg-base-300">
            <li><a class="prose prose-2xl dark:prose-invert">Restaurant</a></li>
            <li><a>Sidebar Item 1</a></li>
            <li><a>Sidebar Item 2</a></li>
        </ul>

    </div>
</div>