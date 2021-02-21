import { Component, Input, OnInit } from '@angular/core';
import { UserVisitsStatistics } from '../../models/user-visits-statistics';

@Component({
  selector: 'app-top-active-users',
  templateUrl: './top-active-users.component.html',
  styleUrls: ['./top-active-users.component.scss']
})
export class TopActiveUsersComponent implements OnInit {
  @Input() limit: number = 10;
  @Input() usersStatistics: UserVisitsStatistics[] = []

  constructor() { }

  ngOnInit(): void {
  }

}
