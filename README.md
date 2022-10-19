# eDentist

eDentist is the application made for dentist and dental workers for optimized working environment.

eDentist is also made for patients to be able to reach doctors easier than before and request appointments.

**Application is consisted of:**
- Desktop application - used by administrators to manage the whole system, staff members to manage appointments, examinations and create reports
- Mobile application - used by patients to book appointment with certain doctor, view history of appointments, examinations, being able to pay online for an examination

Examination payments are implemented using a Stripe payment system (https://stripe.com/), and some of the test cards can be found on: https://stripe.com/docs/testing

**How to start**

- Clone repository
- Locate docker-compose.yml file
- run `docker-compose -f docker-compose.yml build` command
- run `docker-compose -f docker-compose.yml up` command
- Locate eDentist.WinUI application and run it
- Locate edentistmobile application and run it


**Login credentials:**
```
Administrator - Desktop:

Username: Administrator
Password: test

Staff - Desktop:

Username: Staff
Password: test

Patient - Mobile:

Username: Patient
Password: test
```

