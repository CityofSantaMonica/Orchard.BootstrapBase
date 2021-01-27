function collapseContent(rootSelector, highLevel, lowLevel) {
    var slugs = {};
    $(rootSelector).each(function (containerIndex) {
        var parent = $(this);
        for (level = lowLevel; level >= highLevel; level--) {
            var targetHeading = parent.find("h" + level + ":not(:has(>a))").each(function (index) {
                var heading = $(this);
                //create the unique slug for this heading
                var slug = "h" + level + "-" + heading.text().toLowerCase().replace(/ /g, '-').replace(/[^\w-]+/g, '');
                if (slug in slugs) {
                    slugs[slug] = slugs[slug] + 1;
                    slug = slug + "_" + slugs[slug];
                }
                else {
                    slugs[slug] = 1;
                }
                //apply attributes required for collapsible
                heading.attr({ "aria-expanded": "false", "aria-controls": slug, "data-toggle": "collapse", href: "#" + slug });
                //determine child content
                var breakingHeaders = "h" + level;
                for (sublevel = level - 1; sublevel >= 1; sublevel--) {
                    breakingHeaders += ",h" + sublevel;
                }
                //wrap child content in collapsible container
                var downstream = heading.nextUntil(breakingHeaders);
                var panel = $("<div></div>").attr({ id: slug, "class": "collapse" });
                downstream.wrapAll(panel);
            });
        }
    });
}
