import React from 'react';
import './App.css';
import { RouterProvider } from "react-router-dom";
import AuthProvider from "./contexts/auth.context";
import LoadingComponent from "./components/loading.component";
import router from "./routes/routes";
import CartProvider from "./contexts/cart.context";

function App() {
	return (
		<AuthProvider>
			<CartProvider>
				<RouterProvider fallbackElement={ <LoadingComponent/> } router={ router }/>
			</CartProvider>
		</AuthProvider>
	);
}

export default App;
