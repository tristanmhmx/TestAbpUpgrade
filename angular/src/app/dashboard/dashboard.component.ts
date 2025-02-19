import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  template: `
    <app-host-dashboard *abpPermission="'TestUpgrade.Dashboard.Host'"></app-host-dashboard>
    <app-tenant-dashboard *abpPermission="'TestUpgrade.Dashboard.Tenant'"></app-tenant-dashboard>
  `,
})
export class DashboardComponent {}
