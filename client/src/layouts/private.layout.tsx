import { FC, useContext } from "react";
import MainLayout from "./main.layout";
import { AuthContext, IAuthContext } from "../contexts/auth.context";
import LoadingComponent from "../components/loading.component";
import { Navigate } from "react-router-dom";

type PrivateLayoutProps = {}

const PrivateLayout: FC<PrivateLayoutProps> = ( {} ) => {
	const { isAuth, isLoading } = useContext(AuthContext) as IAuthContext;

	return (
		<>
			{ isLoading ? <LoadingComponent/> : isAuth ? <MainLayout/> :
				<Navigate to='/auth/login'/> }
		</>
	)
}

export default PrivateLayout;
