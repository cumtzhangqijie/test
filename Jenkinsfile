pipeline {
  agent any
  stages {
    stage('echo') {
      parallel {
        stage('echo') {
          steps {
            sleep 1
          }
        }
        stage('echo 2') {
          steps {
            sleep 2
          }
        }
      }
    }
    stage('step2') {
      steps {
        sh 'mkdir /home/bill/testjenkinsfile'
      }
    }
    stage('step3') {
      steps {
        echo 'alala'
      }
    }
  }
}