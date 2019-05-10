// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function Episode(data) {
    this.title = ko.observable(data.title);
    this.series = ko.observable(data.series);
    this.airedAt = ko.observable(data.airedAt);
}

function EpisodeListViewModel() {
    // Data
    var self = this;
    this.newEpisodeTitle = ko.observable();
    this.newSeasonTitle = ko.observable();
    this.newAiringDate = ko.observable();

    self.episodes = ko.observableArray([]);

    // Operations
    self.addEpisode = function() {
        if (this.newEpisodeTitle()) self.episodes.push(new Episode({ title: this.newEpisodeTitle(), series: this.newSeasonTitle(), airedAt: this.newAiringDate() }));
    };
    self.removeEpisode = function(episode) { console.log(JSON.stringify(episode)); self.episodes.remove(episode) };
    self.save = function() {
        $.ajax("/episodes/updateall", {
            data: ko.toJSON({ episodes: self.episodes }),
            type: "post", contentType: "application/json",
            success: function(result) { alert(result) }
        });
    };

    // Load initial state from server, convert it to Episode instances, then populate self.episodes
    $.getJSON("/episodes", function(allData) {
        var mappedEpisodes = $.map(allData, function(episode) { return new Episode(episode) });
        self.episodes(mappedEpisodes);
    });    
}

ko.applyBindings(new EpisodeListViewModel());