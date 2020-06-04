import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { SeedingService } from "../../modelo/seedingService";

@Injectable({
  providedIn: "root"
})
export class BaseServico {
  private baseURL: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }
  public seed(): Observable<SeedingService> {
    const headers = new HttpHeaders();
    var body = {}
    return this.http.post<SeedingService>(this.baseURL + "api/base", body, { headers });
  }
}
