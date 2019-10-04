import { Component, ViewChild, OnInit, Inject, LOCALE_ID } from '@angular/core';
import { CalendarComponent } from 'ionic2-calendar/calendar';
import { AppointmentService } from '../shared/appointment.service';
import { Appointment } from '../shared/appointment.model';
import { formatDate } from '@angular/common';
import { AlertController } from '@ionic/angular';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage implements OnInit {
  event = {
    title: '',
    desc: '',
    startTime: '',
    endTime: '',
    allDay: false
  };

  eventSource = [];

  calendar = {
    mode: 'month',
    currentDate: new Date()
  };

  listAppointments;

  viewTitle = 'DrSavvy App';

  @ViewChild(CalendarComponent, { static: false }) myCal: CalendarComponent;

  constructor(
    private service: AppointmentService,
    private alertCtrl: AlertController,
    @Inject(LOCALE_ID) private locale: string
    ) {

  }

  // tslint:disable-next-line: use-lifecycle-interface
  ngOnInit() {
    this.service.appoinments = [];

    // this.service.getAppointmentList().then(res => this.service.appoinments = res as Appointment[]);



    console.log('ngOnInit hit');

    this.service.getAppointmentList().subscribe((res: Appointment) => {
      this.listAppointments = res;
      // console.log('response from service: ', res);
      // console.log('response from listAppointments: ', this.listAppointments);

      for (let i of this.listAppointments) {
        let eventCopy = {
          title: i.FullName,
          desc: i.AppDescr,
          startTime: new Date(i.StartDateTime),
          endTime: new Date(i.EndDateTime),
          allDay: false
        };
        this.eventSource.push(eventCopy);
        this.myCal.loadEvents();
      }
    });


  }

  // Change between month/week/day
  changeMode(mode) {
    this.calendar.mode = mode;
  }

 // Change current month/week/day
  next() {
    var swiper = document.querySelector('.swiper-container')['swiper'];
    swiper.slideNext();
  }
 
  back() {
    var swiper = document.querySelector('.swiper-container')['swiper'];
    swiper.slidePrev();
  }

  today() {
    this.calendar.currentDate = new Date();
  }

  async onEventSelected(event) {
    // Use Angular date pipe for conversion
    let start = formatDate(event.startTime, 'medium', this.locale);
    let end = formatDate(event.endTime, 'medium', this.locale);

    const alert = await this.alertCtrl.create({
      header: event.title,
      subHeader: event.desc,
      message: 'From: ' + start + '<br><br>To: ' + end,
      buttons: ['OK']
    });
    alert.present();
  }

  onViewTitleChanged(title) {
    this.viewTitle = title;
  }

  onTimeSelected(ev) {
    let selected = new Date(ev.selectedTime);
    this.event.startTime = selected.toISOString();
    selected.setHours(selected.getHours() + 1);
    this.event.endTime = (selected.toISOString());
  }

}
