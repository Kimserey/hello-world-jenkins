@Library('my-shared-library') _

properties([
  parameters([
    string(name: 'MESSAGE', defaultValue: 'HEY HEY', description: 'Some message')
   ])
])

def test = params.MESSAGE

stage ("Shared Library Test") {
  
  log.info "test info!"
  
  log {
    type = "warning"
    message = "test warning closure!"
  }

  println test

  log {
    type = "info"
    message = params.MESSAGE
  }
}