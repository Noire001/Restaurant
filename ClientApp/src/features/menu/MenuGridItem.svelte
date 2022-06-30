<script>
    import {Item} from "../../lib/models/Item.ts";

    export let item
</script>


<div class="card w-128 bg-base-100 shadow-xl">
    <figure><img src="https://loremflickr.com/650/350" alt="Placeholder Image" /></figure>
    <div class="card-body">
        <h2 class="card-title">
            {item.title}
        </h2>
        <p>{item.description}</p>
        <div class="card-actions justify-end">
            <p class="text-4xl text-right">{item.price}€</p>
        </div>
    </div>
</div>