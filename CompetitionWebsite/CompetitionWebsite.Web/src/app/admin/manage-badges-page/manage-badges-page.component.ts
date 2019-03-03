import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BadgeService } from '../../core/services/badge.service';
import * as $ from 'jquery';
import { Badge } from '../../shared/models/badge.model';
import * as $ from 'jquery';

@Component({
  selector: 'app-manage-badges-page',
  templateUrl: './manage-badges-page.component.html',
  styleUrls: ['./manage-badges-page.component.css']
})
export class ManageBadgesPageComponent implements OnInit {

  form: FormGroup;

  badges: Badge[];
  tableBadges: Badge[];
  invalidBadge: boolean = false;

  constructor(private formBuilder: FormBuilder,
    private badgeService: BadgeService) { }

  ngOnInit() {
    this.getBadges();
    this.initForm();
  }

  initForm() {
    this.form = this.formBuilder.group({
      "Id": [0],
      "Title": ["", Validators.maxLength(100)],
      "IconPath": ["", Validators.maxLength(1000)],
    });
    this.invalidBadge = false;

  }

  getBadges() {
    this.badgeService.getAllBadges().subscribe(result => {
      this.badges = result;
      this.setTableBadges(1);
    });
  }

  setTableBadges(page: number) {
    this.tableBadges = this.badges;
    this.tableBadges = this.tableBadges.slice((page - 1) * 5, page * 5);
  }

  getPages() {
    let pages: number[] = [];
    for (let x = 1; x <= ((this.badges.length - 1) / 5) + 1; x++) {
      pages.push(x);
    }
    return pages;
  }

  editBadge(badge: Badge) {
    this.form = this.formBuilder.group({
      "Id": [badge.Id],
      "Title": [badge.Title, Validators.maxLength(100)],
      "IconPath": [badge.IconPath, Validators.maxLength(1000)],
    });
    this.invalidBadge = false;

  }

  deleteBadge(badge: Badge) {
    this.badgeService.deleteBadge(badge).subscribe(result => {
      this.getBadges();
    },
      error => {
        $("#deleteError").show();
      });
  }

  formatReleaseYear(ReleaseYear: string) {
    return ReleaseYear.substring(0, 10);
  }

  saveBadge() {
    this.invalidBadge = false;
    let badge: Badge = this.form.value;
    if (badge.Title.length === 0 || badge.IconPath.length === 0) {
      this.invalidBadge = true;
      return;
    }
    this.badgeService.saveBadge(badge).subscribe(result => {
      $("[data-dismiss=modal]").trigger({ type: "click" });
      this.getBadges();
    });

  }


}
