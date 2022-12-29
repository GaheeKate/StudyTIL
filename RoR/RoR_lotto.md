# Ruby on Rails,RoR
 
Today I studied Ruby on Rails 

- similar to python
- controller: rails g(generate) controller lotto(name)
- view: index.html.erb(embedded ruby)
- link: def index end
- routes: get '/gogo', to: 'lotto#index'
- copy element from lotto site, then go network to find CSS for copied CSS class. paste it to assets-stylesheets-app.css

```ruby

Rails.application.routes.draw do
 get '/gogo', to: 'lotto#index'
end
------
class LottoController < ApplicationController
	def index
		@number = [*1..49]
		@pick = @number.sample(6).sort 
	end
end
-------
<p>
    <div class="selected lotto-ball"><div class="ball-number"><%= @pick[0] %></div></div>
    <div class="selected lotto-ball"><div class="ball-number"><%= @pick[1] %></div></div>
    <div class="selected lotto-ball"><div class="ball-number"><%= @pick[2] %></div></div>
    <div class="selected lotto-ball"><div class="ball-number"><%= @pick[3] %></div></div>
    <div class="selected lotto-ball"><div class="ball-number"><%= @pick[4] %></div></div>
    <div class="selected lotto-ball"><div class="ball-number"><%= @pick[5] %></div></div>

</p>
```