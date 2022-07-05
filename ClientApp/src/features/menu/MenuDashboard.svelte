<script lang="ts">
    import {store} from "../../lib/stores/store";
    import MenuGrid from "./MenuGrid.svelte";
    const itemRegistry = store.menuItemStore.menuItemRegistry
    store.menuItemStore.loadItems();

</script>
{#if $itemRegistry.size > 0}
    <div id="menu-dashboard" class="container-lg mx-auto">
        <MenuGrid/>
    </div>
{/if}