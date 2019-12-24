import { Component } from '@angular/core';
import { CredentialService, RepositoryService } from 'src/app/_services';
import { MatSnackBar, MatDialog, MatIconRegistry } from '@angular/material';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  constructor(public credentialService: CredentialService, private dialog: MatDialog, private matIconRegistry: MatIconRegistry,
              private domSanitizer: DomSanitizer) {

    this.matIconRegistry.addSvgIcon(
      `vehicle`,
      this.domSanitizer.bypassSecurityTrustResourceUrl('./assets/img/vehicle.svg')
    );

    this.matIconRegistry.addSvgIcon(
      `driver`,
      this.domSanitizer.bypassSecurityTrustResourceUrl('./assets/img/driver.svg')
    );

    this.matIconRegistry.addSvgIcon(
      `vendor`,
      this.domSanitizer.bypassSecurityTrustResourceUrl('./assets/img/vendor.svg')
    );

  }

  editProfile() {

  }

  logout() {
    this.credentialService.logout();
  }


}
