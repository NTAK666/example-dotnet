export type PagedResponse<T> = {
	pageNumber: number,
	pageSize: number,
	firstPage: string,
	lastPage: string,
	totalPages: number,
	data?: T,
	totalRecords: number,
	nextPage: string,
	previousPage: string
}

export type Response<T> = {}
