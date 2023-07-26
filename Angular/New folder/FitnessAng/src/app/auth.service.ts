import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private userUrl = "https://localhost:7238/api/User";
  private formUrl = "https://localhost:7238/api/Formdata";
  private registerUrl = "https://localhost:7238/api/Register";

  constructor(private http: HttpClient) { }

  public postUser(user: any): Observable<any> {
    return this.http.post(this.formUrl, user);
  }

  public getUser(user: any): Observable<any> {
    return this.http.get(this.formUrl, user);
  }

  public postLogin(user: any): Observable<any> {
    return this.http.post(this.userUrl, user);
  }

  public postRegister(user: any): Observable<any> {
    return this.http.post(this.registerUrl, user);
  }
 
}
