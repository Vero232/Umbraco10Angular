import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Hero } from '../hero';
import { HeroService } from '../hero.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: [ './dashboard.component.css' ]
})
export class DashboardComponent implements OnInit {
  heroes: Hero[] = [];

  constructor(private HeroService: HeroService) { }
  
  ngOnInit(): void {
  this.getHeroesFromApi();

  }

  getHeroesFromApi(): void {
    this.HeroService.getHeroesFromApi().subscribe((response) =>{

      this.heroes = response;
    })
  }

  
}