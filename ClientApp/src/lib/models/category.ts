import {Item} from "./item";

export interface Category {
    id: number;
    name: string;
    priority: number;
    items: Item[];
}

export class Category implements Category {

}