import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';

@Component({
  selector: 'admin-root',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit{
  title = 'Admin';

  ngOnInit() {
    $("#deleteError").hide();
  }

  hideError() {
      $("#deleteError").hide();
  }

}
