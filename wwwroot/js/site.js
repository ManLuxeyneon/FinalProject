// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

<script>
        // Get the button
    const button = document.querySelector('button');

    // Get the hidden container
    const hiddenContainer = document.querySelector('.hidden-container');

        // Add event listener to the button
        button.addEventListener('click', () => {
        // Toggle the visibility of the hidden container
        hiddenContainer.style.display = hiddenContainer.style.display === 'none' ? 'block' : 'none';
        });
</script>
