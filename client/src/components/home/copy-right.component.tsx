import { FC } from "react";

type CopyRightComponentProps = {}

const CopyRightComponent: FC<CopyRightComponentProps> = ( {} ) => {
	return (
		<div className='bg-gray-800 py-4'>
			<div className='container flex items-center justify-between'>
				<p className='text-white'>&copy; ECommerce - All Right Reserved</p>
				<div>
					<img src='assets/images/methods.png' alt='methods' className='h-5'/>
				</div>
			</div>
		</div>
	)
}

export default CopyRightComponent;
