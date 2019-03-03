import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Competition } from '../../../shared/models/competition.model';
import { CompetitionService } from '../../../core/services/competition.service';
import { Router } from '@angular/router';
import { CompetitionStatus } from '../../../shared/enums/competition-status.enum';

@Component({
  selector: 'app-manage-competition-page',
  templateUrl: './manage-competition-page.component.html',
  styleUrls: ['./manage-competition-page.component.css']
})
export class ManageCompetitionPageComponent implements OnInit {

  form: FormGroup;

  competitions: Competition[];
  tableCompetitions: Competition[];

  constructor(private formBuilder: FormBuilder,
    private competitionService: CompetitionService,
    private route: Router) { }

  ngOnInit() {
    this.getCompetitions();
    this.initForm();
  }

  initForm() {

  }

  getCompetitions() {
    this.competitionService.getAllCompetitions().subscribe(result => {
      this.competitions = result;
      this.setTableCompetitions(1);
    });
  }

  setTableCompetitions(page: number) {
    this.tableCompetitions = this.competitions;
    this.tableCompetitions = this.tableCompetitions.slice((page - 1) * 5, page * 5);
  }

  getPages() {
    let pages: number[] = [];
    for (let x = 1; x <= ((this.competitions.length - 1) / 5) + 1; x++) {
      pages.push(x);
    }
    return pages;
  }

  editCompetition(competition: Competition) {
    console.log(competition);
    this.route.navigate(["admin/manage/competitions/edit/" + competition.Id]);
  }

  deleteCompetition(competition: Competition) {
    this.competitionService.deleteCompetition(competition).subscribe(result => {
      this.getCompetitions();
    });
  }

  formatReleaseYear(ReleaseYear: string) {
    return ReleaseYear.substring(0, 10);
  }

  formatStatus(status: number) {
    return CompetitionStatus[status];
  }

}
