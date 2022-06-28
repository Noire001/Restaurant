<script>
    import Icon from "@iconify/svelte";
    export let drawerId;
</script>


<div class="w-full navbar height:200px">
    <input id="{drawerId}" type="checkbox" class="drawer-toggle" />
    <div class="flex-none lg:hidden">
        <label for="{drawerId}" class="btn btn-square btn-ghost">
            <Icon icon="charm:menu-hamburger" width="36" height="36" />
        </label>
    </div>
    <div class="flex-1 px-2 mx-2 ">Navbar Title</div>
    <div class="flex-none hidden lg:block ">
        <ul class="menu menu-horizontal ">
            <!-- Navbar menu content here -->
            <li><a>Navbar Item 1</a></li>
            <li><a>Navbar Item 2</a></li>
        </ul>
    </div>
</div>
<slot />