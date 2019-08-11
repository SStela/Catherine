import { Pagination } from './Pagination';

export class PaginatedResponse<T> {
    count?: number;
    totalCount?: number;
    data: T | Array<T>;
    public get pagination(): Pagination {
        return {
            count: this.count,
            totalCount: this.totalCount,
            pageSize: this.count
        };
    }
}