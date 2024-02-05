// src/app/trip-list/trip-list.component.ts

import { Component, OnInit } from '@angular/core';
import { TripService } from '../trip.service';

//@Component({
 // selector: 'app-trip-list',
//  templateUrl: './trip-list.component.html',
//  styleUrls: ['./trip-list.component.css']
//})
export class TripListComponent implements OnInit {
  trips: any[];

  constructor(private tripService: TripService) { }

  ngOnInit(): void {
    this.tripService.getTrips().subscribe(trips => {
      this.trips = trips;
    });
  }
}
