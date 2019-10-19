$(document).ready(function () {
    ko.applyBindings(new AppViewModel());
});

function AppViewModel() {
    var self = this;

    self.project = ko.observableArray([
        { name: 'projectid' },
        { name: 'credits' },
        { name: 'status' }
    ]);
}