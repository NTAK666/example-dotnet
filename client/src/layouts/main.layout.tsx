import React, { FC, useContext } from "react";
import HeaderComponent from "../components/home/header.component";
import NavComponent from "../components/home/nav.component";
import { Outlet } from "react-router-dom";
import FooterComponent from "../components/home/footer.component";
import CopyRightComponent from "../components/home/copy-right.component";
import { AuthContext, IAuthContext } from "../contexts/auth.context";
import LoadingComponent from "../components/loading.component";

type MainLayoutProps = {}

const MainLayout: FC<MainLayoutProps> = () => {

	const { isLoading, getMeAgain } = useContext(AuthContext) as IAuthContext;


	return (
		isLoading ? <LoadingComponent/> : (
			<>
				<HeaderComponent/>

				<NavComponent/>

				<div className='min-h-[1000px]'>
					<Outlet/>
				</div>

				<FooterComponent/>

				<CopyRightComponent/>
			</>
		)
	)
}

export default MainLayout;
