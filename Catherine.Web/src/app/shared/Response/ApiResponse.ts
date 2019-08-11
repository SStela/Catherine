import { PaginatedResponse } from './PaginatedResponse';

export class ApiResponse<T> {
    success: boolean;
    code: number;
    response: PaginatedResponse<T>;
}