import {get, writable} from 'svelte/store';
import type {Item} from "../models/Item";
import agent from "../api/agent";

export default class MenuItemStore {
    menuItemRegistry = writable<Map<string, Item>>(undefined);
    
    loadItems = async () => {
        const items = await agent.MenuItems.list();
        const result = new Map(items.map(item => [item.id, item]));
        this.menuItemRegistry.set(result);
        
    }
    
    get menuItemsByCategory() {
        let items = new Map<string, Item[]>();
        get(this.menuItemRegistry).forEach(item => {
            if (!items.has(item.category)) {
                items.set(item.category, []);
            }
            items.get(item.category)!.push(item);
        })
        return items;
    }
}