import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs';
import { Result } from "../models/result";

@Injectable()
export class AgeWeightCalcService {
  constructor(private http: Http, @Inject('ORIGIN_URL') private originUrl: string) { }

  calcAgeWeight(ageCollection){
   return this.http.post('/api/agecalc/', ageCollection)
      .map(res => res);
     //.map(this.extractData));
  }
  extractData(res: Response) {
    let body = res.json();
    return body || {};
  }
}
