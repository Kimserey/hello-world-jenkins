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
				dir('src') {
					steps {
						sh "dotnet build"
					}
				}
			}
        }

        stage('test') {
			steps {
				dir('test') {
					steps {
						sh "dotnet test"
					}
				}
			}
        }

        stage('publish') {
			steps {
				dir('src') {
					steps {
						sh "dotnet publish"
					}
				}
			}
        }
    }
}