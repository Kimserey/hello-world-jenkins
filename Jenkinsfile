@Library('my-shared-library') _

properties([
  parameters([
    string(name: 'MESSAGE', defaultValue: 'HEY HEY', description: 'Some message')
   ])
])


stage ("Shared Library Test") {
  
  log.info "test info!"
  
  def x = ["a", "b", "c"]
  def y = x.each { it.val = it.val + "what?" }
  println y

  log {
    type = "warning"
    message = "test warning closure!"
  }

  def msg = params.MESSAGE

  log {
    type = "info"
    message = msg
  }
}