import {writable} from 'svelte/store';
import type {Item} from "../models/Item";
import agent from "../api/agent";

export default class MenuItemStore {
    menuItemRegistry = writable<Map<string, Item>>(undefined);
    
    loadItems = async () => {
        const items = await agent.MenuItems.list();
        const result = new Map(items.map(item => [item.id, item]));
        this.menuItemRegistry.set(result);
        
    }
}