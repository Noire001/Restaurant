import type {Item} from "../models/item";
import {Category} from "../models/category";

const baseURL = "http://localhost:5141";

const MenuItems = {
    // list: () => requests.list<Item[]>(`${baseURL}/api/menuitem`),
    list: () => fetch(`${baseURL}/api/menuitem`).then(async response => await response.json() as Promise<Item[]>),
    listByCategory: () => fetch(`${baseURL}/api/menuitem/categories`).then(async response => await response.json() as Promise<Category[]>),
}

const agent = {
    MenuItems,
}

export default agent