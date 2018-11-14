properties([
  parameters([
    string(name: 'VERSION', defaultValue: '0.0.0', description: 'version')
   ])
])

@Library('my-shared-library') _

def test = "test"

node ("master") {
    stage ("QA") {
		  println test
      log.info "test!"
    }
}
