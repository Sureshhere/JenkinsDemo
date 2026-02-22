pipeline {
    agent any

    stages {

        stage('Restore') {
            steps { bat 'dotnet restore' }
        }

        stage('Build') {
            steps { bat 'dotnet build -c Release' }
        }

        stage('Test') {
            steps {
                bat 'dotnet test -c Release --logger "junit;LogFilePath=test_results.xml"'
            }
        }

        stage('Publish') {
            steps {
                bat 'dotnet publish JenkinsDemo/JenkinsDemo.csproj -c Release -o publish'
            }
        }
    }

    post {
        always {
            junit '**/test_results.xml'
        }
    }
}