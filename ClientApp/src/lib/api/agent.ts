import type {Item} from "../models/Item";

const baseURL = "http://localhost:5141";
const requests = {
    list: <T>(url: string) => fetch(url).then(async response => await response.json() as Promise<Item[]>),
}

const MenuItems = {
    list: () => requests.list<Item[]>(`${baseURL}/api/menuitem`),
}

const agent = {
    MenuItems,
}

export default agent