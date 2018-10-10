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
			dir('src') {
				steps {
					sh "dotnet build"
				}
			}
        }

        stage('test') {
			dir('test') {
				steps {
					sh "dotnet test"
				}
			}
        }

        stage('publish') {
			dir('src') {
				steps {
					sh "dotnet publish"
				}
			}
        }
    }
}