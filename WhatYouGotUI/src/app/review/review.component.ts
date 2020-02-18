import { Component, OnInit } from '@angular/core';
import { ReviewService } from '../Services/fridgethingsServices/review.service';
import { Review } from '../Models/fridgethingsModels/review';


@Component({
  selector: 'app-review',
  templateUrl: './review.component.html',
  styleUrls: ['./review.component.css']
})
export class ReviewComponent implements OnInit {

  constructor(private reviewService: ReviewService) { }

  ngOnInit(): void {
  }

  addReview(userId: number, recipeId: number, rating: number, comment: string) {
    var review: Review = {userId: userId, recipeId: recipeId, rating: +rating, comment: comment}
    console.log(review);
    this.reviewService.postReview(review).subscribe();
  }
}
