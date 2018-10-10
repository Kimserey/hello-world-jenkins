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
				steps {
					sh "cd src && dotnet build"
				}
			}
        }

        stage('test') {
			steps {
				steps {
					sh "cd test && dotnet test"
				}
			}
        }

        stage('publish') {
			steps {
				dir('src') {
					sh "cd src && dotnet publish"
				}
			}
        }
    }
}