import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { AgeCollection } from '../models/ageCollection';
import { AgeWeightCalcService } from "../services/ageWeightCalcService";
import { Result } from "../models/result";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  ageCollection: AgeCollection = new AgeCollection();
  ageResult: string = '';

  constructor(private ageWeightService: AgeWeightCalcService) {

  }

  onSubmit(form: NgForm) {
    var formdata = this.ageCollection;
    formdata.age = this.ageCollection.age;
    formdata.weight = this.ageCollection.weight;

    //Call service here
    this.ageWeightService.calcAgeWeight(formdata)
      .subscribe(x => {
        console.log(x.text());
        this.ageResult = x.text();
      });
  }
}


