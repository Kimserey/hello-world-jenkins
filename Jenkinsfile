pipeline {
    agent any

	options {
		skipDefaultCheckout true
	}

	stages {
        stage('checkout') {
            steps {
                checkout scm
            }
        }

        stage('build') {
            steps {
                sh "dotnet build"
            }
        }

        stage('test') {
            steps {
                sh "dotnet test"
            }
        }

        stage('publish') {
            steps {
                sh "dotnet publish"
            }
        }
    }
}