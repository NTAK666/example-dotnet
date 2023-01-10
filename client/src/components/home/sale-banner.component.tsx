import { FC } from "react";

type SaleBannerComponentProps = {}

const SaleBannerComponent: FC<SaleBannerComponentProps> = ( {} ) => {
	return (
		<div className='container pb-16'>
			<a href='src/components#'>
				<img src='assets/images/offer.jpg' alt='ads' className='w-full'/>
			</a>
		</div>
	)
}

export default SaleBannerComponent;
