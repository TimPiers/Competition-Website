import { Component, OnInit } from '@angular/core';
import { GameService } from '../../core/services/Game.service';
import { Game } from '../../shared/models/Game.model';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import * as $ from 'jquery';

@Component({
  selector: 'app-manage-games-page',
  templateUrl: './manage-games-page.component.html',
  styleUrls: ['./manage-games-page.component.css']
})


export class ManageGamesPageComponent implements OnInit {

  form: FormGroup;

  games: Game[];
  tableGames: Game[];
  invalidGame: boolean = false;

  constructor(private formBuilder: FormBuilder,
    private gameService: GameService) { }

  ngOnInit() {
    this.getGames();
    this.initForm();
  }

  initForm() {
    this.form = this.formBuilder.group({
      "Id": [0],
      "Name": ["", Validators.maxLength(100)],
      "Description": ["", Validators.maxLength(5000)],
      "ReleaseYear": []
    });
    this.invalidGame = false;

  }

  getGames() {
    this.gameService.getAllGames().subscribe(result => {
      this.games = result;
      this.setTableGames(1);
    });
  }

  setTableGames(page: number) {
    this.tableGames = this.games;
    this.tableGames = this.tableGames.slice((page - 1) * 5, page * 5);
  }

  getPages() {
    let pages: number[] = [];
    for (let x = 1; x <= ((this.games.length - 1) / 5) + 1; x++) {
      pages.push(x);
    }
    return pages;
  }

  editGame(game: Game) {
    this.form = this.formBuilder.group({
      "Id": [game.Id],
      "Name": [game.Name, Validators.maxLength(100)],
      "Description": [game.Description, Validators.maxLength(5000)],
      "ReleaseYear": [this.formatReleaseYear(game.ReleaseYear.toString())]
    });
    this.invalidGame = false;

  }

  deleteGame(game: Game) {
    this.gameService.deleteGame(game).subscribe(result => {
      this.getGames();
    },
      error => {
        $("#deleteError").show();
      });
  }

  formatReleaseYear(ReleaseYear: string) {
    return ReleaseYear.substring(0, 10);
  }

  saveGame() {
    this.invalidGame = false;
    let game: Game = this.form.value;
    if (game.Name.length === 0 || game.Description.length === 0 || game.ReleaseYear === null || isNaN(new Date(game.ReleaseYear).getTime())) {
      this.invalidGame = true;
      return;
    }
    this.gameService.saveGame(game).subscribe(result => {
      $("[data-dismiss=modal]").trigger({ type: "click" });
      this.getGames();
    });

  }


}
