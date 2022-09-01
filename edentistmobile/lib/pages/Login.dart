import 'package:flutter/material.dart';

class Login extends StatefulWidget
 {
  @override
  _LoginState createState() => _LoginState();
}

class _LoginState extends State<Login> {
  TextEditingController usernameController = TextEditingController();
  TextEditingController passwordController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Container(
      decoration: const BoxDecoration(
          image: DecorationImage(
        image: AssetImage('assets/bg.png'),
        fit: BoxFit.cover,
      )),
      child: Scaffold(
          backgroundColor: Colors.transparent,
          body: ListView(
            children: [
              Padding(
                padding: const EdgeInsets.all(50),
                child: Column(
                  //mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    Row(
                      children: const [
                        Text(
                          'eDentist',
                          style: TextStyle(
                              fontSize: 36,
                              color: Colors.white,
                              fontWeight: FontWeight.bold,
                              fontStyle: FontStyle.italic),
                        )
                      ],
                    ),
                    const SizedBox(
                      height: 20,
                    ),
                    TextField(
                      controller: usernameController,
                      decoration: InputDecoration(
                          border: OutlineInputBorder(
                            borderRadius: BorderRadius.circular(15),
                          ),
                          hintText: 'Username'),
                    ),
                    const SizedBox(
                      height: 20,
                    ),
                    TextField(
                      controller: passwordController,
                      decoration: InputDecoration(
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(15)),
                          focusColor: Colors.white,
                          hintText: 'Password'),
                    ),
                    const SizedBox(
                      height: 20,
                    ),
                    Container(
                      height: 60,
                      width: 300,
                      decoration: BoxDecoration(
                          color: Colors.lightBlue,
                          borderRadius: BorderRadius.circular(20)),
                      child: TextButton(
                        onPressed: () async {
                          ScaffoldMessenger.of(context)
                              .showSnackBar(const SnackBar(
                            content: SizedBox(
                                height: 20,
                                child: Center(child: Text('error'))),
                            backgroundColor: Color.fromARGB(255, 100, 9, 13),
                          ));
                        },
                        child: const Text(
                          'Login',
                          style: TextStyle(color: Colors.white, fontSize: 20),
                        ),
                      ),
                    )
                  ],
                ),
              ),
            ],
          )),
    );
  }
}
