<script lang="ts">
    import {store} from "../../lib/stores/store";
    import MenuGridItem from "./MenuGridItem.svelte";

    $:itemsByCategory = store.menuItemStore.menuItemRegistry;
</script>


{#each [...$itemsByCategory] as [key, value]}
    <h1 id={`menu-${key.toLowerCase()}`} class="text-5xl mt-4 font-medium leading-normal">{key}</h1>
    <div class="grid grid-cols-1 md:grid-cols-2 xl:grid-cols-3 gap-4 place-items-stretch">
        {#each value as item}
            <MenuGridItem item={item}/>
        {/each}
    </div>
{/each}
