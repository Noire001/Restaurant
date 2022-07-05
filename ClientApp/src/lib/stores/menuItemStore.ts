import {get, writable} from 'svelte/store';
import type {Item} from "../models/item";
import agent from "../api/agent";

export default class MenuItemStore {
    menuItemRegistry = writable<Map<string, Item[]>>(new Map<string, Item[]>());
    
    loadItems = async () => {
        const categories = await agent.MenuItems.listByCategory();
        categories.sort((a, b) => a.priority - b.priority);
        const result = new Map(categories.map(category => [category.name, category.items]));
        this.menuItemRegistry.set(result);
    }
}