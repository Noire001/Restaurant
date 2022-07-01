<script>
    import {store} from "../../lib/stores/store.ts";
    import MenuGrid from "./MenuGrid.svelte";
    const itemRegistry = store.menuItemStore.menuItemRegistry
    store.menuItemStore.loadItems();

</script>
{#if $itemRegistry !== undefined}
    <div class="container-lg mx-auto">
        <MenuGrid/>
    </div>
{/if}