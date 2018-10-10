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
				sh "dotnet build src/HelloWorldJenkins"
			}
        }

        stage('test') {
			steps {
				sh "dotnet test test/HelloWorldJenkins.UnitTests"
			}
        }
    }
}