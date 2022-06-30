<script>
    import {store} from "../../lib/stores/store.ts";
    import MenuGridItem from "./MenuGridItem.svelte";

    let itemStore = store.menuItemStore.menuItemRegistry;
</script>

<div class="grid grid-cols-1 md:grid-cols-2 xl:grid-cols-3 gap-4 place-items-stretch">
{#each [...$itemStore] as [key,value]}
    <MenuGridItem item={value} />
{/each}
</div>