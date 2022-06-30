import MenuItemStore from "./menuItemStore";

interface Store {
    menuItemStore: MenuItemStore;
}

export const store: Store = {
    menuItemStore: new MenuItemStore()
}