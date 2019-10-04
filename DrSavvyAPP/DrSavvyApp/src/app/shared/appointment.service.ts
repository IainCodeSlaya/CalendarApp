import { Injectable } from '@angular/core';
import { Appointment } from './appointment.model';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AppointmentService {
  apiURL = 'https://localhost:44335/api';

  // formData: Appointment;
  appoinments: Appointment[];

  constructor(private http: HttpClient) { }

  getAppointmentList() {
    // return this.http.get(environment.apiURL + '/MobileApps').toPromise();
    return this.http.get(this.apiURL + '/MobileApps');
  }
}
