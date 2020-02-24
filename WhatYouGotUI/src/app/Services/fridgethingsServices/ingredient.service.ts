import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Ingredient } from '../../Models/fridgethingsModels/ingredient';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class IngredientService {

  constructor(private httpClient: HttpClient) { }

  ingredientUrl = 'https://fridgethingsapi.azurewebsites.net/api/Ingredients/' 
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  getIngredients(): Promise<Ingredient[]> {
    console.log(this.ingredientUrl);
    return this.httpClient.get<Ingredient[]>(this.ingredientUrl).toPromise();
  }

  getIngredientById(id: number): Promise<Ingredient> {
    var completeUrl = `${this.ingredientUrl}${id}`;
    console.log(completeUrl);
    return this.httpClient.get<Ingredient>(completeUrl).toPromise();
  }

  getIngredientByRecipeId(rid:number): Promise<Ingredient[]>{ 
    var alternateURL = `http://fridgethingsapi.azurewebsites.net/ByRecipe/${rid}`;
    return this.httpClient.get<Ingredient[]>(alternateURL).toPromise();
  }

  postIngredient(newIngredient: Ingredient): Observable<Ingredient> {
    console.log(this.ingredientUrl);
    console.log(newIngredient);
    return this.httpClient.post<Ingredient>(this.ingredientUrl, newIngredient, this.httpOptions);
  }

  putIngredient(newIngredient: Ingredient): Observable<any> {
    var completeUrl = `${this.ingredientUrl}${newIngredient.id}`;
    console.log(completeUrl);
    return this.httpClient.put(completeUrl, newIngredient, this.httpOptions);
  }

  deleteIngredient(id: number): Observable<Ingredient> {
    var completeUrl = `${this.ingredientUrl}${id}`;
    console.log(completeUrl);
    return this.httpClient.delete<Ingredient>(completeUrl, this.httpOptions);
  }
}
