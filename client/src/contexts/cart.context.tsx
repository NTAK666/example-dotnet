import React, { createContext, useEffect, useState } from "react";
import { Product } from "../services/product/product.services";

export type Carts = {
	carts: CartItem[]
}

export type CartItem = {
	product: Product,
	quantity: number
}

export interface ICartContext {
	cart?: Carts;
	updateCart: ( CartItem: CartItem ) => void;
	removeItem: ( CartItem: CartItem ) => void;
	updateQuantity: ( CartItem: CartItem, quantity: number ) => void;
	clearCart: () => void;
}

interface ICartProvider {
	children: React.ReactNode;
}

export const CartContext = createContext<ICartContext | null>(null);
const CartProvider: React.FC<ICartProvider> = ( { children } ) => {

	const [cart, setCart] = useState<Carts>({
		carts: []
	});

	useEffect(() => {
		const cart = localStorage.getItem("cart");
		if (cart) {
			setCart(JSON.parse(cart));
		}
	}, [])

	const saveToLocal = () => {
		localStorage.setItem("cart", JSON.stringify(cart));
	}

	const updateQuantity = ( cartItem: CartItem, quantity: number ) => {
		const newCart = cart.carts.map(( item ) => {
			if (item.product.id === cartItem.product.id) {
				item.quantity = quantity;
			}
			return item;
		})
		setCart({ carts: newCart });
		saveToLocal();
	}

	const updateCart = ( cartItem: CartItem ) => {
		const index = cart.carts.findIndex(item => item.product.id === cartItem.product.id);
		if (index !== -1) {
			cart.carts[index].quantity += cartItem.quantity;
		} else {
			cart.carts.push(cartItem);
		}
		setCart({ ...cart });
		saveToLocal();
	}
	const removeItem = ( cartItem: CartItem ) => {
		const { carts } = cart;
		const newCart = carts.filter(item => item.product.id !== cartItem.product.id);
		setCart({
			carts: newCart
		})
		saveToLocal();
	}

	const clearCart = () => {
		setCart({
			carts: []
		})
		saveToLocal();
	}

	return (
		<CartContext.Provider
			value={ {
				cart,
				updateCart,
				removeItem,
				updateQuantity,
				clearCart
			} }>
			{ children }
		</CartContext.Provider>
	);
};

export default CartProvider;
