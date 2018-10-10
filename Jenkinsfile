pipeline {
    agent any

	options {
		skipDefaultCheckout true
	}

	stages {
        stage('init') {
			steps {
				echo "Hello world"
			}
		}

        stage('checkout') {
            steps {
                checkout scm
            }
        }

        stage('build') {
			steps {
				withCredentials([string(credentialsId: 'mysecret', variable: 'SECRET')]) {
					sh """
						set +x
						echo $SECRET
					"""
				}

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