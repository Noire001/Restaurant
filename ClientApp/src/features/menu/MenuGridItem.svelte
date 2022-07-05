<script lang="ts">
    import {Item} from "../../lib/models/Item";

    export let item: Item
</script>


<div class="card w-96 bg-base-100 shadow-md rounded-sm">
    <figure ><img src="https://loremflickr.com/600/350" alt="Placeholder Image" /></figure>
    <div class="card-body ">
        <h2 class="card-title">
            {item.title}
        </h2>
        <p>{item.description}</p>
        <div class="card-actions justify-end">
            <p class="text-2xl text-right -mb-2">{item.price}€</p>
        </div>
    </div>
</div>