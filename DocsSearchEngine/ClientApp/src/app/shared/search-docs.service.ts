import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SearchDocsService {

    private searchResults: any[];

    constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

    resultSubject = new BehaviorSubject(null);

    GetResults(query: string) {
        let model = {
            "content": query,
            "metadata": ""
        }
        this.http.post<any[]>(this.baseUrl + 'api/SearchDocs', model).subscribe(result => {
            this.searchResults = result;
            this.resultSubject.next(result);
        }, error => console.error(error));
    }
}
